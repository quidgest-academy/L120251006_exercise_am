<template>
	<teleport
		v-if="formModalIsReady && showFormHeader"
		:to="`#${uiContainersId.header}`"
		:disabled="!isPopup || isNested">
		<div
			ref="formHeader"
			:class="{ 'c-sticky-header': isStickyHeader, 'sticky-top': isStickyTop }">
			<div
				v-if="showFormHeader"
				class="c-action-bar">
				<h1
					v-if="formControl.uiComponents.header && formInfo.designation"
					:id="formTitleId"
					class="form-header">
					{{ formInfo.designation }}
				</h1>

				<div class="c-action-bar__menu">
					<template
						v-for="(section, sectionId) in formButtonSections"
						:key="sectionId">
						<span
							v-if="showHeadingSep(sectionId)"
							class="main-title-sep" />

						<q-toggle-group
							v-if="formControl.uiComponents.headerButtons"
							borderless>
							<template
								v-for="btn in section"
								:key="btn.id">
								<q-toggle-group-item
									v-if="showFormHeaderButton(btn)"
									:model-value="btn.isSelected"
									:id="`top-${btn.id}`"
									:title="btn.text"
									:label="btn.label"
									:disabled="btn.disabled"
									@click="btn.action">
									<q-icon
										v-if="btn.icon"
										v-bind="btn.icon" />
								</q-toggle-group-item>
							</template>
						</q-toggle-group>
					</template>
				</div>
			</div>

			<q-anchor-container-horizontal
				v-if="$app.layout.FormAnchorsPosition === 'form-header' && visibleGroups.length > 0"
				:anchors="anchorGroups"
				:controls="visibleControls"
				@focus-control="focusControl" />
		</div>
	</teleport>

	<teleport
		v-if="formModalIsReady && showFormBody"
		:to="`#${uiContainersId.body}`"
		:disabled="!isPopup || isNested">
		<q-validation-summary
			:messages="validationErrors"
			@error-clicked="focusField" />

		<div :class="[`float-${actionsPlacement}`, 'c-action-bar']">
			<q-button-group borderless>
				<template
					v-for="btn in formButtons"
					:key="btn.id">
					<q-button
						v-if="btn.isActive && btn.isVisible && btn.showInHeading"
						:id="`heading-${btn.id}`"
						:label="btn.text"
						:variant="btn.variant"
						:disabled="btn.disabled"
						:icon-pos="btn.iconPos"
						:class="btn.classes"
						@click="btn.action(); btn.emitAction ? $emit(btn.emitAction.name, btn.emitAction.params) : null">
						<q-icon
							v-if="btn.icon"
							v-bind="btn.icon" />
					</q-button>
				</template>
			</q-button-group>
		</div>

		<div
			class="form-flow"
			data-key="FR_002"
			:data-loading="!formInitialDataLoaded">
			<template v-if="formControl.initialized && showFormBody">
				<q-row-container
					v-if="controls.FR_002__PSEUDNEWGRP01.isVisible"
					is-large>
					<q-control-wrapper
						v-if="controls.FR_002__PSEUDNEWGRP01.isVisible"
						class="row-line-group">
						<q-group-box-container
							v-if="controls.FR_002__PSEUDNEWGRP01.isVisible"
							id="FR_002__PSEUDNEWGRP01"
							v-bind="controls.FR_002__PSEUDNEWGRP01"
							:is-visible="controls.FR_002__PSEUDNEWGRP01.isVisible">
							<!-- Start FR_002__PSEUDNEWGRP01 -->
							<q-row-container
								v-if="controls.FR_002__T_002F_001___.isVisible"
								is-large>
								<q-control-wrapper
									v-if="controls.FR_002__T_002F_001___.isVisible"
									class="row-line-group">
									<base-input-structure
										v-if="controls.FR_002__T_002F_001___.isVisible"
										class="q-image"
										v-bind="controls.FR_002__T_002F_001___"
										v-on="controls.FR_002__T_002F_001___.handlers"
										:loading="controls.FR_002__T_002F_001___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-image
											v-if="controls.FR_002__T_002F_001___.isVisible"
											v-bind="controls.FR_002__T_002F_001___.props"
											v-on="controls.FR_002__T_002F_001___.handlers" />
									</base-input-structure>
								</q-control-wrapper>
							</q-row-container>
							<q-row-container v-if="controls.FR_002__T_002F_002___.isVisible || controls.FR_002__T_002F_003___.isVisible">
								<q-control-wrapper
									v-if="controls.FR_002__T_002F_002___.isVisible"
									class="control-join-group">
									<base-input-structure
										v-if="controls.FR_002__T_002F_002___.isVisible"
										class="i-text"
										v-bind="controls.FR_002__T_002F_002___"
										v-on="controls.FR_002__T_002F_002___.handlers"
										:loading="controls.FR_002__T_002F_002___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-text-field
											v-bind="controls.FR_002__T_002F_002___.props"
											@blur="onBlur(controls.FR_002__T_002F_002___, model.ValTitle.value)"
											@change="model.ValTitle.fnUpdateValueOnChange" />
									</base-input-structure>
								</q-control-wrapper>
								<q-control-wrapper
									v-if="controls.FR_002__T_002F_003___.isVisible"
									class="control-join-group">
									<base-input-structure
										v-if="controls.FR_002__T_002F_003___.isVisible"
										class="i-text"
										v-bind="controls.FR_002__T_002F_003___"
										v-on="controls.FR_002__T_002F_003___.handlers"
										:loading="controls.FR_002__T_002F_003___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-numeric-input
											v-if="controls.FR_002__T_002F_003___.isVisible"
											v-bind="controls.FR_002__T_002F_003___.props"
											@update:model-value="model.ValPrice.fnUpdateValue" />
									</base-input-structure>
								</q-control-wrapper>
							</q-row-container>
							<!-- End FR_002__PSEUDNEWGRP01 -->
						</q-group-box-container>
					</q-control-wrapper>
				</q-row-container>
				<q-row-container
					v-if="controls.FR_002__PSEUDNEWGRP05.isVisible"
					is-large>
					<q-control-wrapper
						v-if="controls.FR_002__PSEUDNEWGRP05.isVisible"
						class="row-line-group">
						<q-accordion
							v-if="controls.FR_002__PSEUDNEWGRP05.isVisible"
							id="FR_002__PSEUDNEWGRP05"
							v-model="controls.FR_002__PSEUDNEWGRP05.openChild">
							<!-- Start FR_002__PSEUDNEWGRP05 -->
							<q-accordion-item
								v-if="controls.FR_002__PSEUDNEWGRP02.isVisible"
								id="FR_002__PSEUDNEWGRP02-container"
								value="FR_002__PSEUDNEWGRP02"
								:title="controls.FR_002__PSEUDNEWGRP02.label">
								<!-- Start FR_002__PSEUDNEWGRP02 -->
								<q-row-container v-if="controls.FR_002__T_004F_001___.isVisible">
									<q-control-wrapper
										v-if="controls.FR_002__T_004F_001___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_004F_001___.isVisible"
											class="i-text"
											v-bind="controls.FR_002__T_004F_001___"
											v-on="controls.FR_002__T_004F_001___.handlers"
											:loading="controls.FR_002__T_004F_001___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-lookup
												v-if="controls.FR_002__T_004F_001___.isVisible"
												v-bind="controls.FR_002__T_004F_001___.props"
												v-on="controls.FR_002__T_004F_001___.handlers" />
											<q-see-more-fr002-t004f001
												v-if="controls.FR_002__T_004F_001___.seeMoreIsVisible"
												v-bind="controls.FR_002__T_004F_001___.seeMoreParams"
												v-on="controls.FR_002__T_004F_001___.handlers" />
										</base-input-structure>
									</q-control-wrapper>
								</q-row-container>
								<q-row-container v-if="controls.FR_002__T_003F_001___.isVisible">
									<q-control-wrapper
										v-if="controls.FR_002__T_003F_001___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_003F_001___.isVisible"
											class="i-text"
											v-bind="controls.FR_002__T_003F_001___"
											v-on="controls.FR_002__T_003F_001___.handlers"
											:loading="controls.FR_002__T_003F_001___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-text-field
												v-bind="controls.FR_002__T_003F_001___.props"
												@blur="onBlur(controls.FR_002__T_003F_001___, model.T_004T_003ValCountry.value)"
												@change="model.T_004T_003ValCountry.fnUpdateValueOnChange" />
										</base-input-structure>
									</q-control-wrapper>
								</q-row-container>
								<!-- End FR_002__PSEUDNEWGRP02 -->
							</q-accordion-item>
							<q-accordion-item
								v-if="controls.FR_002__PSEUDNEWGRP03.isVisible"
								id="FR_002__PSEUDNEWGRP03-container"
								value="FR_002__PSEUDNEWGRP03"
								:title="controls.FR_002__PSEUDNEWGRP03.label">
								<!-- Start FR_002__PSEUDNEWGRP03 -->
								<q-row-container v-if="controls.FR_002__T_002F_009___.isVisible || controls.FR_002__T_002F_007___.isVisible || controls.FR_002__T_002F_008___.isVisible">
									<q-control-wrapper
										v-if="controls.FR_002__T_002F_009___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_002F_009___.isVisible"
											class="i-text"
											v-bind="controls.FR_002__T_002F_009___"
											v-on="controls.FR_002__T_002F_009___.handlers"
											:loading="controls.FR_002__T_002F_009___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-numeric-input
												v-if="controls.FR_002__T_002F_009___.isVisible"
												v-bind="controls.FR_002__T_002F_009___.props"
												@update:model-value="model.ValYearbuilt.fnUpdateValue" />
										</base-input-structure>
									</q-control-wrapper>
									<q-control-wrapper
										v-if="controls.FR_002__T_002F_007___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_002F_007___.isVisible"
											class="i-text"
											v-bind="controls.FR_002__T_002F_007___"
											v-on="controls.FR_002__T_002F_007___.handlers"
											:loading="controls.FR_002__T_002F_007___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-numeric-input
												v-if="controls.FR_002__T_002F_007___.isVisible"
												v-bind="controls.FR_002__T_002F_007___.props"
												@update:model-value="model.ValSize.fnUpdateValue" />
										</base-input-structure>
									</q-control-wrapper>
									<q-control-wrapper
										v-if="controls.FR_002__T_002F_008___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_002F_008___.isVisible"
											class="i-text"
											v-bind="controls.FR_002__T_002F_008___"
											v-on="controls.FR_002__T_002F_008___.handlers"
											:loading="controls.FR_002__T_002F_008___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-numeric-input
												v-if="controls.FR_002__T_002F_008___.isVisible"
												v-bind="controls.FR_002__T_002F_008___.props"
												@update:model-value="model.ValBathnumber.fnUpdateValue" />
										</base-input-structure>
									</q-control-wrapper>
								</q-row-container>
								<!-- End FR_002__PSEUDNEWGRP03 -->
							</q-accordion-item>
							<q-accordion-item
								v-if="controls.FR_002__PSEUDNEWGRP04.isVisible"
								id="FR_002__PSEUDNEWGRP04-container"
								value="FR_002__PSEUDNEWGRP04"
								:title="controls.FR_002__PSEUDNEWGRP04.label">
								<!-- Start FR_002__PSEUDNEWGRP04 -->
								<q-row-container v-if="controls.FR_002__T_001F_002___.isVisible">
									<q-control-wrapper
										v-if="controls.FR_002__T_001F_002___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_001F_002___.isVisible"
											class="i-text"
											v-bind="controls.FR_002__T_001F_002___"
											v-on="controls.FR_002__T_001F_002___.handlers"
											:loading="controls.FR_002__T_001F_002___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-lookup
												v-if="controls.FR_002__T_001F_002___.isVisible"
												v-bind="controls.FR_002__T_001F_002___.props"
												v-on="controls.FR_002__T_001F_002___.handlers" />
											<q-see-more-fr002-t001f002
												v-if="controls.FR_002__T_001F_002___.seeMoreIsVisible"
												v-bind="controls.FR_002__T_001F_002___.seeMoreParams"
												v-on="controls.FR_002__T_001F_002___.handlers" />
										</base-input-structure>
									</q-control-wrapper>
								</q-row-container>
								<q-row-container v-if="controls.FR_002__T_001F_001___.isVisible">
									<q-control-wrapper
										v-if="controls.FR_002__T_001F_001___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_001F_001___.isVisible"
											class="i-text"
											v-bind="controls.FR_002__T_001F_001___"
											v-on="controls.FR_002__T_001F_001___.handlers"
											:loading="controls.FR_002__T_001F_001___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-text-field
												v-bind="controls.FR_002__T_001F_001___.props"
												@blur="onBlur(controls.FR_002__T_001F_001___, model.T_001ValName.value)"
												@change="model.T_001ValName.fnUpdateValueOnChange" />
										</base-input-structure>
									</q-control-wrapper>
								</q-row-container>
								<q-row-container v-if="controls.FR_002__T_001F_004___.isVisible">
									<q-control-wrapper
										v-if="controls.FR_002__T_001F_004___.isVisible"
										class="control-join-group">
										<base-input-structure
											v-if="controls.FR_002__T_001F_004___.isVisible"
											class="q-image"
											v-bind="controls.FR_002__T_001F_004___"
											v-on="controls.FR_002__T_001F_004___.handlers"
											:loading="controls.FR_002__T_001F_004___.props.loading"
											:reporting-mode-on="reportingModeCAV"
											:suggestion-mode-on="suggestionModeOn">
											<q-image
												v-if="controls.FR_002__T_001F_004___.isVisible"
												v-bind="controls.FR_002__T_001F_004___.props"
												v-on="controls.FR_002__T_001F_004___.handlers" />
										</base-input-structure>
									</q-control-wrapper>
								</q-row-container>
								<!-- End FR_002__PSEUDNEWGRP04 -->
							</q-accordion-item>
							<!-- End FR_002__PSEUDNEWGRP05 -->
						</q-accordion>
					</q-control-wrapper>
				</q-row-container>
			</template>
		</div>
	</teleport>

	<hr v-if="!isPopup && showFormFooter" />

	<teleport
		v-if="formModalIsReady && showFormFooter"
		:to="`#${uiContainersId.footer}`"
		:disabled="!isPopup || isNested">
		<q-row-container v-if="showFormFooter">
			<div id="footer-action-btns">
				<template
					v-for="btn in formButtons"
					:key="btn.id">
					<q-button
						v-if="btn.isActive && btn.isVisible && btn.showInFooter"
						:id="`bottom-${btn.id}`"
						:label="btn.text"
						:variant="btn.variant"
						:disabled="btn.disabled"
						:icon-pos="btn.iconPos"
						:class="btn.classes"
						@click="btn.action(); btn.emitAction ? $emit(btn.emitAction.name, btn.emitAction.params) : null">
						<q-icon
							v-if="btn.icon"
							v-bind="btn.icon" />
					</q-button>
				</template>
			</div>
		</q-row-container>
	</teleport>
</template>

<script>
	/* eslint-disable @typescript-eslint/no-unused-vars */
	import { computed, defineAsyncComponent, readonly } from 'vue'
	import { useRoute } from 'vue-router'

	import FormHandlers from '@/mixins/formHandlers.js'
	import formFunctions from '@/mixins/formFunctions.js'
	import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
	import listFunctions from '@/mixins/listFunctions.js'
	import listColumnTypes from '@/mixins/listColumnTypes.js'
	import modelFieldType from '@quidgest/clientapp/models/fields'
	import fieldControlClass from '@/mixins/fieldControl.js'
	import qEnums from '@quidgest/clientapp/constants/enums'
	import { resetProgressBar, setProgressBar } from '@/utils/layout.js'

	import hardcodedTexts from '@/hardcodedTexts.js'
	import netAPI from '@quidgest/clientapp/network'
	import asyncProcM from '@quidgest/clientapp/composables/async'
	import qApi from '@/api/genio/quidgestFunctions.js'
	import qFunctions from '@/api/genio/projectFunctions.js'
	import qProjArrays from '@/api/genio/projectArrays.js'
	/* eslint-enable @typescript-eslint/no-unused-vars */

	import FormViewModel from './QFormFr002ViewModel.js'

	const requiredTextResources = ['QFormFr002', 'hardcoded', 'messages']

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FORM_INCLUDEJS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

	export default {
		name: 'QFormFr002',

		components: {
			QSeeMoreFr002T004f001: defineAsyncComponent(() => import('@/views/forms/FormFr002/dbedits/Fr002T004f001SeeMore.vue')),
			QSeeMoreFr002T001f002: defineAsyncComponent(() => import('@/views/forms/FormFr002/dbedits/Fr002T001f002SeeMore.vue')),
		},

		mixins: [
			FormHandlers
		],

		props: {
			/**
			 * Parameters passed in case the form is nested.
			 */
			nestedRouteParams: {
				type: Object,
				default: () => ({
					name: 'FR_002',
					location: 'form-FR_002',
					params: {
						isNested: true
					}
				})
			}
		},

		expose: [
			'cancel',
			'initFormProperties',
			'navigationId'
		],

		setup(props)
		{
			const route = useRoute()

			return {
				/*
				 * As properties are reactive, when using $route.params, then when we exit it updates cached components.
				 * Properties have no value and this creates an error in new versions of vue-router.
				 * That's why the value has to be copied to a local property to be used in the router-link tag.
				 */
				currentRouteParams: props.isNested ? {} : route.params
			}
		},

		data()
		{
			// eslint-disable-next-line
			const vm = this
			return {
				componentOnLoadProc: asyncProcM.getProcListMonitor('QFormFr002', false),

				interfaceMetadata: {
					id: 'QFormFr002', // Used for resources
					requiredTextResources
				},

				formInfo: {
					type: 'normal',
					name: 'FR_002',
					route: 'form-FR_002',
					area: 'T_002',
					primaryKey: 'ValCodt_002',
					designation: computed(() => this.Resources.PROPERTY43977),
					identifier: '', // Unique identifier received by route (when it's nested).
					mode: '',
					availableAgents: [],
				},

				formButtons: {
					changeToShow: {
						id: 'change-to-show-btn',
						icon: {
							icon: 'view',
							type: 'svg'
						},
						type: 'form-mode',
						text: computed(() => vm.Resources[hardcodedTexts.view]),
						showInHeader: true,
						showInFooter: false,
						isActive: false,
						isSelected: computed(() => vm.formModes.show === vm.formInfo.mode),
						isVisible: computed(() => vm.authData.isAllowed && [vm.formModes.show, vm.formModes.edit, vm.formModes.delete].includes(vm.formInfo.mode)),
						action: vm.changeToShowMode
					},
					changeToEdit: {
						id: 'change-to-edit-btn',
						icon: {
							icon: 'pencil',
							type: 'svg'
						},
						type: 'form-mode',
						text: computed(() => vm.Resources[hardcodedTexts.edit]),
						showInHeader: true,
						showInFooter: false,
						isActive: false,
						isSelected: computed(() => vm.formModes.edit === vm.formInfo.mode),
						isVisible: computed(() => vm.authData.isAllowed && [vm.formModes.show, vm.formModes.edit, vm.formModes.delete].includes(vm.formInfo.mode)),
						action: vm.changeToEditMode
					},
					changeToDuplicate: {
						id: 'change-to-dup-btn',
						icon: {
							icon: 'duplicate',
							type: 'svg'
						},
						type: 'form-mode',
						text: computed(() => vm.Resources[hardcodedTexts.duplicate]),
						showInHeader: true,
						showInFooter: false,
						isActive: false,
						isSelected: computed(() => vm.formModes.duplicate === vm.formInfo.mode),
						isVisible: computed(() => vm.authData.isAllowed && vm.formModes.new !== vm.formInfo.mode),
						action: vm.changeToDupMode
					},
					changeToDelete: {
						id: 'change-to-delete-btn',
						icon: {
							icon: 'delete',
							type: 'svg'
						},
						type: 'form-mode',
						text: computed(() => vm.Resources[hardcodedTexts.delete]),
						showInHeader: true,
						showInFooter: false,
						isActive: false,
						isSelected: computed(() => vm.formModes.delete === vm.formInfo.mode),
						isVisible: computed(() => vm.authData.isAllowed && [vm.formModes.show, vm.formModes.edit, vm.formModes.delete].includes(vm.formInfo.mode)),
						action: vm.changeToDeleteMode
					},
					changeToInsert: {
						id: 'change-to-insert-btn',
						icon: {
							icon: 'add',
							type: 'svg'
						},
						type: 'form-insert',
						text: computed(() => vm.Resources[hardcodedTexts.insert]),
						label: computed(() => vm.Resources[hardcodedTexts.insert]),
						showInHeader: true,
						showInFooter: false,
						isActive: false,
						isSelected: computed(() => vm.formModes.new === vm.formInfo.mode),
						isVisible: computed(() => vm.authData.isAllowed && vm.formModes.duplicate !== vm.formInfo.mode),
						action: vm.changeToInsertMode
					},
					repeatInsertBtn: {
						id: 'repeat-insert-btn',
						icon: {
							icon: 'save-new',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.Resources[hardcodedTexts.repeatInsert]),
						variant: 'bold',
						showInHeader: true,
						showInFooter: true,
						isActive: false,
						isVisible: computed(() => vm.authData.isAllowed && vm.formInfo.mode === vm.formModes.new),
						action: () => vm.saveForm(true)
					},
					saveBtn: {
						id: 'save-btn',
						icon: {
							icon: 'save',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.Resources.GRAVAR45301),
						variant: 'bold',
						showInHeader: true,
						showInFooter: true,
						isActive: true,
						isVisible: computed(() => vm.authData.isAllowed && vm.isEditable),
						action: vm.saveForm
					},
					confirmBtn: {
						id: 'confirm-btn',
						icon: {
							icon: 'check',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.Resources[vm.isNested ? hardcodedTexts.delete : hardcodedTexts.confirm]),
						variant: 'bold',
						showInHeader: true,
						showInFooter: true,
						isActive: true,
						isVisible: computed(() => vm.authData.isAllowed && (vm.formInfo.mode === vm.formModes.delete || vm.isNested)),
						action: vm.deleteRecord
					},
					cancelBtn: {
						id: 'cancel-btn',
						icon: {
							icon: 'cancel',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.Resources.CANCELAR49513),
						showInHeader: true,
						showInFooter: true,
						isActive: true,
						isVisible: computed(() => vm.authData.isAllowed && vm.isEditable),
						action: vm.leaveForm
					},
					resetCancelBtn: {
						id: 'reset-cancel-btn',
						icon: {
							icon: 'cancel',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.Resources[hardcodedTexts.cancel]),
						showInHeader: true,
						showInFooter: true,
						isActive: false,
						isVisible: computed(() => vm.authData.isAllowed && vm.isEditable),
						action: () => vm.model.resetValues(),
						emitAction: {
							name: 'deselect',
							params: {}
						}
					},
					editBtn: {
						id: 'edit-btn',
						icon: {
							icon: 'pencil',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.Resources[hardcodedTexts.edit]),
						variant: 'bold',
						showInHeader: true,
						showInFooter: false,
						isActive: false,
						isVisible: computed(() => vm.authData.isAllowed && vm.parentFormMode !== vm.formModes.show && vm.parentFormMode !== vm.formModes.delete),
						action: () => {},
						emitAction: {
							name: 'edit',
							params: {}
						}
					},
					deleteQuickBtn: {
						id: 'delete-btn',
						icon: {
							icon: 'bin',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.Resources[hardcodedTexts.delete]),
						variant: 'bold',
						showInHeader: true,
						showInFooter: false,
						isActive: false,
						isVisible: computed(() => vm.authData.isAllowed && vm.parentFormMode !== vm.formModes.show && (typeof vm.permissions.canDelete === 'boolean' ? vm.permissions.canDelete : true)),
						action: vm.deleteRecord
					},
					backBtn: {
						id: 'back-btn',
						icon: {
							icon: 'back',
							type: 'svg'
						},
						type: 'form-action',
						text: computed(() => vm.isPopup ? vm.Resources[hardcodedTexts.close] : vm.Resources[hardcodedTexts.goBack]),
						showInHeader: true,
						showInFooter: true,
						isActive: true,
						isVisible: computed(() => !vm.authData.isAllowed || !vm.isEditable),
						action: vm.leaveForm
					}
				},

				controls: {
					FR_002__PSEUDNEWGRP01: new fieldControlClass.GroupControl({
						id: 'FR_002__PSEUDNEWGRP01',
						name: 'NEWGRP01',
						size: 'block',
						label: computed(() => this.Resources.MAIN_INFOS57373),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						isCollapsible: false,
						anchored: false,
						directChildren: ['FR_002__T_002F_001___', 'FR_002__T_002F_002___', 'FR_002__T_002F_003___'],
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__T_002F_001___: new fieldControlClass.ImageControl({
						modelField: 'ValPhoto',
						valueChangeEvent: 'fieldChange:t_002.photo',
						id: 'FR_002__T_002F_001___',
						name: 'F_001',
						size: 'block',
						label: computed(() => this.Resources.PROPERTY_PHOTO29666),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP01',
						height: 50,
						width: 30,
						dataTitle: computed(() => genericFunctions.formatString(vm.Resources.IMAGEM_UTILIZADA_PAR17299, vm.Resources.PROPERTY_PHOTO29666)),
						maxFileSize: 10485760, // In bytes.
						maxFileSizeLabel: '10 MB',
						controlLimits: [
						],
					}, this),
					FR_002__T_002F_002___: new fieldControlClass.StringControl({
						modelField: 'ValTitle',
						valueChangeEvent: 'fieldChange:t_002.title',
						id: 'FR_002__T_002F_002___',
						name: 'F_002',
						size: 'xxlarge',
						label: computed(() => this.Resources.PROPERTY_TITLE56931),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP01',
						maxLength: 50,
						labelId: 'label_FR_002__T_002F_002___',
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__T_002F_003___: new fieldControlClass.CurrencyControl({
						modelField: 'ValPrice',
						valueChangeEvent: 'fieldChange:t_002.price',
						id: 'FR_002__T_002F_003___',
						name: 'F_003',
						size: 'medium',
						label: computed(() => this.Resources.PROPERTY_PRICE21441),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP01',
						maxIntegers: 9,
						maxDecimals: 2,
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__PSEUDNEWGRP05: new fieldControlClass.AccordionControl({
						id: 'FR_002__PSEUDNEWGRP05',
						name: 'NEWGRP05',
						size: 'block',
						label: computed(() => this.Resources.NEW_GROUP63448),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						isCollapsible: false,
						anchored: false,
						directChildren: ['FR_002__PSEUDNEWGRP02', 'FR_002__PSEUDNEWGRP03', 'FR_002__PSEUDNEWGRP04'],
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__PSEUDNEWGRP02: new fieldControlClass.GroupControl({
						id: 'FR_002__PSEUDNEWGRP02',
						name: 'NEWGRP02',
						size: 'block',
						label: computed(() => this.Resources.LOCALIZATION34148),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP05',
						isInAccordion: true,
						isCollapsible: true,
						anchored: false,
						directChildren: ['FR_002__T_004F_001___', 'FR_002__T_003F_001___'],
						controlLimits: [
						],
					}, this),
					FR_002__T_004F_001___: new fieldControlClass.LookupControl({
						modelField: 'TableT_004F_001',
						valueChangeEvent: 'fieldChange:t_004.city',
						id: 'FR_002__T_004F_001___',
						name: 'F_001',
						size: 'xxlarge',
						label: computed(() => this.Resources.CITY42505),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP02',
						externalCallbacks: {
							getModelField: vm.getModelField,
							getModelFieldValue: vm.getModelFieldValue,
							setModelFieldValue: vm.setModelFieldValue
						},
						externalProperties: {
							modelKeys: computed(() => vm.modelKeys)
						},
						lookupKeyModelField: {
							name: 'ValCodt_004',
							dependencyEvent: 'fieldChange:t_002.codt_004'
						},
						dependentFields: () => ({
							set 't_004.codt_004'(value) { vm.model.ValCodt_004.updateValue(value) },
							set 't_004.city'(value) { vm.model.TableT_004F_001.updateValue(value) },
							set 't_003.country'(value) { vm.model.T_004T_003ValCountry.updateValue(value) },
						}),
						controlLimits: [
						],
					}, this),
					FR_002__T_003F_001___: new fieldControlClass.StringControl({
						modelField: 'T_004T_003ValCountry',
						valueChangeEvent: 'fieldChange:t_003.country',
						dependentModelField: 'ValCodt_003',
						dependentChangeEvent: 'fieldChange:t_004.codt_003',
						id: 'FR_002__T_003F_001___',
						name: 'F_001',
						size: 'xlarge',
						label: computed(() => this.Resources.COUNTRY_NAME26113),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP02',
						maxLength: 50,
						labelId: 'label_FR_002__T_003F_001___',
						controlLimits: [
						],
					}, this),
					FR_002__PSEUDNEWGRP03: new fieldControlClass.GroupControl({
						id: 'FR_002__PSEUDNEWGRP03',
						name: 'NEWGRP03',
						size: 'block',
						label: computed(() => this.Resources.DETAILS19591),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP05',
						isInAccordion: true,
						isCollapsible: true,
						anchored: false,
						directChildren: ['FR_002__T_002F_009___', 'FR_002__T_002F_007___', 'FR_002__T_002F_008___'],
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__T_002F_009___: new fieldControlClass.NumberControl({
						modelField: 'ValYearbuilt',
						valueChangeEvent: 'fieldChange:t_002.yearbuilt',
						id: 'FR_002__T_002F_009___',
						name: 'F_009',
						size: 'small',
						label: computed(() => this.Resources.YEAR_BUILT55277),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP03',
						maxIntegers: 4,
						maxDecimals: 0,
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__T_002F_007___: new fieldControlClass.NumberControl({
						modelField: 'ValSize',
						valueChangeEvent: 'fieldChange:t_002.size',
						id: 'FR_002__T_002F_007___',
						name: 'F_007',
						size: 'small',
						label: computed(() => this.Resources.SIZE10299),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP03',
						maxIntegers: 6,
						maxDecimals: 3,
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__T_002F_008___: new fieldControlClass.NumberControl({
						modelField: 'ValBathnumber',
						valueChangeEvent: 'fieldChange:t_002.bathnumber',
						id: 'FR_002__T_002F_008___',
						name: 'F_008',
						size: 'medium',
						label: computed(() => this.Resources.BATHROUMS_NUMBER42941),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP03',
						maxIntegers: 2,
						maxDecimals: 0,
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_002__PSEUDNEWGRP04: new fieldControlClass.GroupControl({
						id: 'FR_002__PSEUDNEWGRP04',
						name: 'NEWGRP04',
						size: 'block',
						label: computed(() => this.Resources.AGENT00994),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP05',
						isInAccordion: true,
						isCollapsible: true,
						anchored: false,
						directChildren: ['FR_002__T_001F_002___', 'FR_002__T_001F_001___', 'FR_002__T_001F_004___'],
						controlLimits: [
						],
					}, this),
					FR_002__T_001F_002___: new fieldControlClass.LookupControl({
						modelField: 'TableT_001F_002',
						valueChangeEvent: 'fieldChange:t_001.email',
						id: 'FR_002__T_001F_002___',
						name: 'F_002',
						size: 'xxlarge',
						label: computed(() => this.Resources.EMAIL25170),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP04',
						externalCallbacks: {
							getModelField: vm.getModelField,
							getModelFieldValue: vm.getModelFieldValue,
							setModelFieldValue: vm.setModelFieldValue
						},
						externalProperties: {
							modelKeys: computed(() => vm.modelKeys)
						},
						lookupKeyModelField: {
							name: 'ValCodt_001',
							dependencyEvent: 'fieldChange:t_002.codt_001'
						},
						dependentFields: () => ({
							set 't_001.codt_001'(value) { vm.model.ValCodt_001.updateValue(value) },
							set 't_001.email'(value) { vm.model.TableT_001F_002.updateValue(value) },
							set 't_001.name'(value) { vm.model.T_001ValName.updateValue(value) },
							set 't_001.photo'(value) { vm.model.T_001ValPhoto.updateValue(value) },
						}),
						controlLimits: [
						],
					}, this),
					FR_002__T_001F_001___: new fieldControlClass.StringControl({
						modelField: 'T_001ValName',
						valueChangeEvent: 'fieldChange:t_001.name',
						dependentModelField: 'ValCodt_001',
						dependentChangeEvent: 'fieldChange:t_002.codt_001',
						id: 'FR_002__T_001F_001___',
						name: 'F_001',
						size: 'xlarge',
						label: computed(() => this.Resources.NAME31974),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP04',
						maxLength: 50,
						labelId: 'label_FR_002__T_001F_001___',
						controlLimits: [
						],
					}, this),
					FR_002__T_001F_004___: new fieldControlClass.ImageControl({
						modelField: 'T_001ValPhoto',
						valueChangeEvent: 'fieldChange:t_001.photo',
						dependentModelField: 'ValCodt_001',
						dependentChangeEvent: 'fieldChange:t_002.codt_001',
						id: 'FR_002__T_001F_004___',
						name: 'F_004',
						size: 'mini',
						label: computed(() => this.Resources.PROFILE_PHOTO12166),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_002__PSEUDNEWGRP04',
						height: 50,
						width: 30,
						dataTitle: computed(() => genericFunctions.formatString(vm.Resources.IMAGEM_UTILIZADA_PAR17299, vm.Resources.PROFILE_PHOTO12166)),
						maxFileSize: 10485760, // In bytes.
						maxFileSizeLabel: '10 MB',
						controlLimits: [
						],
					}, this),
				},

				model: new FormViewModel(this, {
					callbacks: {
						onUpdate: this.onUpdate,
						setFormKey: this.setFormKey
					}
				}),

				groupFields: readonly([
					'FR_002__PSEUDNEWGRP01',
					'FR_002__PSEUDNEWGRP05',
					'FR_002__PSEUDNEWGRP02',
					'FR_002__PSEUDNEWGRP03',
					'FR_002__PSEUDNEWGRP04',
				]),

				tableFields: readonly([
				]),

				timelineFields: readonly([
				]),

				/**
				 * The Data API for easy access to model variables.
				 */
				dataApi: {
					T_001: {
						get ValName() { return vm.model.T_001ValName.value },
						set ValName(value) { vm.model.T_001ValName.updateValue(value) },
						get ValEmail() { return vm.model.TableT_001F_002.value },
						set ValEmail(value) { vm.model.TableT_001F_002.updateValue(value) },
						get ValPhoto() { return vm.model.T_001ValPhoto.value },
						set ValPhoto(value) { vm.model.T_001ValPhoto.updateValue(value) },
					},
					T_002: {
						get ValPhoto() { return vm.model.ValPhoto.value },
						set ValPhoto(value) { vm.model.ValPhoto.updateValue(value) },
						get ValTitle() { return vm.model.ValTitle.value },
						set ValTitle(value) { vm.model.ValTitle.updateValue(value) },
						get ValPrice() { return vm.model.ValPrice.value },
						set ValPrice(value) { vm.model.ValPrice.updateValue(value) },
						get ValCodt_001() { return vm.model.ValCodt_001.value },
						set ValCodt_001(value) { vm.model.ValCodt_001.updateValue(value) },
						get ValCodt_004() { return vm.model.ValCodt_004.value },
						set ValCodt_004(value) { vm.model.ValCodt_004.updateValue(value) },
						get ValSize() { return vm.model.ValSize.value },
						set ValSize(value) { vm.model.ValSize.updateValue(value) },
						get ValBathnumber() { return vm.model.ValBathnumber.value },
						set ValBathnumber(value) { vm.model.ValBathnumber.updateValue(value) },
						get ValYearbuilt() { return vm.model.ValYearbuilt.value },
						set ValYearbuilt(value) { vm.model.ValYearbuilt.updateValue(value) },
					},
					T_003: {
						get ValCountry() { return vm.model.T_004T_003ValCountry.value },
						set ValCountry(value) { vm.model.T_004T_003ValCountry.updateValue(value) },
					},
					T_004: {
						get ValCity() { return vm.model.TableT_004F_001.value },
						set ValCity(value) { vm.model.TableT_004F_001.updateValue(value) },
					},
					keys: {
						/** The primary key of the T_002 table */
						get t_002() { return vm.model.ValCodt_002 },
						/** The foreign key to the T_001 table */
						get t_001() { return vm.model.ValCodt_001 },
						/** The foreign key to the T_004 table */
						get t_004() { return vm.model.ValCodt_004 },
					},
					get extraProperties() { return vm.model.extraProperties },
				},
			}
		},

		beforeRouteEnter(to, _, next)
		{
			// Called before the route that renders this component is confirmed.
			// Does NOT have access to `this` component instance, because
			// it has not been created yet when this guard is called!

			next((vm) => {
				vm.initFormProperties(to)
			})
		},

		beforeRouteLeave(to, _, next)
		{
			if (to.params.isControlled === 'true')
			{
				genericFunctions.setNavigationState(false)
				next()
			}
			else
				this.cancel(next)
		},

		beforeRouteUpdate(to, _, next)
		{
			if (to.params.isControlled === 'true')
				next()
			else
				this.cancel(next)
		},

		mounted()
		{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FORM_CODEJS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		beforeUnmount()
		{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS COMPONENT_BEFORE_UNMOUNT FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		methods: {
			/**
			 * Called before form init.
			 */
			async beforeLoad()
			{
				// Execute the "Before init" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.beforeInit)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				this.emitEvent('before-load-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS BEFORE_LOAD_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				return true
			},

			/**
			 * Called after form init.
			 */
			async afterLoad()
			{
				// Execute the "After init" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.afterInit)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				this.emitEvent('after-load-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FORM_LOADED_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
			},

			/**
			 * Called before an apply action is performed.
			 */
			async beforeApply()
			{
				let applyForm = true // Set to 'false' to cancel form apply.

				// Execute the "Before apply" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.beforeApply)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				const canSetDocums = await this.model.updateFilesTickets(true)

				if (canSetDocums)
				{
					applyForm = await this.model.setDocumentChanges()

					if (applyForm)
					{
						const results = await this.model.saveDocuments()
						applyForm = results.every((e) => e === true)
					}
				}

				this.emitEvent('before-apply-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS BEFORE_APPLY_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				return applyForm
			},

			/**
			 * Called after an apply action is performed.
			 */
			async afterApply()
			{
				// Execute the "After apply" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.afterApply)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				this.emitEvent('after-apply-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS AFTER_APPLY_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
			},

			/**
			 * Called before the record is saved.
			 */
			async beforeSave()
			{
				let saveForm = true // Set to 'false' to cancel form saving.

				// Execute the "Before save" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.beforeSave)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				const canSetDocums = await this.model.updateFilesTickets()

				if (canSetDocums)
				{
					saveForm = await this.model.setDocumentChanges()

					if (saveForm)
					{
						const results = await this.model.saveDocuments()
						saveForm = results.every((e) => e === true)
					}
				}

				this.emitEvent('before-save-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS BEFORE_SAVE_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				return saveForm
			},

			/**
			 * Called after the record is saved.
			 */
			async afterSave()
			{
				// Execute the "After save" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.afterSave)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				this.emitEvent('after-save-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS AFTER_SAVE_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				return true
			},

			/**
			 * Called before the record is deleted.
			 */
			async beforeDel()
			{
				this.emitEvent('before-delete-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS BEFORE_DEL_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				return true
			},

			/**
			 * Called after the record is deleted.
			 */
			async afterDel()
			{
				this.emitEvent('after-delete-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS AFTER_DEL_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				return true
			},

			/**
			 * Called before leaving the form.
			 */
			async beforeExit()
			{
				// Execute the "Before exit" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.beforeExit)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				this.emitEvent('before-exit-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS BEFORE_EXIT_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				return true
			},

			/**
			 * Called after leaving the form.
			 */
			async afterExit()
			{
				// Execute the "After exit" triggers.
				const triggers = this.getTriggers(qEnums.triggerEvents.afterExit)
				for (const trigger of triggers)
					await formFunctions.executeTriggerAction(trigger)

				this.emitEvent('after-exit-form')

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS AFTER_EXIT_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
			},

			/**
			 * Called whenever a field's value is updated.
			 * @param {string} fieldName The name of the field in the format [table].[field] (ex: 'person.name')
			 * @param {object} fieldObject The object representing the field in the model
			 * @param {any} fieldValue The value of the field
			 * @param {any} oldFieldValue The previous value of the field
			 */
			// eslint-disable-next-line
			onUpdate(fieldName, fieldObject, fieldValue, oldFieldValue)
			{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS DLGUPDT FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				this.afterFieldUpdate(fieldName, fieldObject)
			},

			/**
			 * Called whenever a field is unfocused.
			 * @param {*} fieldObject The object representing the field in the model
			 * @param {*} fieldValue The value of the field
			 */
			// eslint-disable-next-line
			onBlur(fieldObject, fieldValue)
			{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS CTRLBLR FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				this.afterFieldUnfocus(fieldObject, fieldValue)
			},

			/**
			 * Called whenever a control's value is updated.
			 * @param {string} controlField The name of the field in the controls that will be updated
			 * @param {object} control The object representing the field in the controls
			 * @param {any} fieldValue The value of the field
			 */
			// eslint-disable-next-line
			onControlUpdate(controlField, control, fieldValue)
			{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS CTRLUPD FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				this.afterControlUpdate(controlField, fieldValue)
			},

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FUNCTIONS_JS FR_002]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		watch: {
		}
	}
</script>
