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
			data-key="FR_001"
			:data-loading="!formInitialDataLoaded">
			<template v-if="formControl.initialized && showFormBody">
				<q-row-container v-if="controls.FR_001__T_001F_008___.isVisible || controls.FR_001__T_001F_009___.isVisible">
					<q-control-wrapper
						v-if="controls.FR_001__T_001F_008___.isVisible"
						class="control-join-group">
						<base-input-structure
							v-if="controls.FR_001__T_001F_008___.isVisible"
							class="i-text"
							v-bind="controls.FR_001__T_001F_008___"
							v-on="controls.FR_001__T_001F_008___.handlers"
							:loading="controls.FR_001__T_001F_008___.props.loading"
							:reporting-mode-on="reportingModeCAV"
							:suggestion-mode-on="suggestionModeOn">
							<q-numeric-input
								v-if="controls.FR_001__T_001F_008___.isVisible"
								v-bind="controls.FR_001__T_001F_008___.props"
								@update:model-value="model.ValPropsold.fnUpdateValue" />
						</base-input-structure>
					</q-control-wrapper>
					<q-control-wrapper
						v-if="controls.FR_001__T_001F_009___.isVisible"
						class="control-join-group">
						<base-input-structure
							v-if="controls.FR_001__T_001F_009___.isVisible"
							class="i-text"
							v-bind="controls.FR_001__T_001F_009___"
							v-on="controls.FR_001__T_001F_009___.handlers"
							:loading="controls.FR_001__T_001F_009___.props.loading"
							:reporting-mode-on="reportingModeCAV"
							:suggestion-mode-on="suggestionModeOn">
							<q-numeric-input
								v-if="controls.FR_001__T_001F_009___.isVisible"
								v-bind="controls.FR_001__T_001F_009___.props"
								@update:model-value="model.ValProfit.fnUpdateValue" />
						</base-input-structure>
					</q-control-wrapper>
				</q-row-container>
				<q-row-container
					v-if="controls.FR_001__PSEUDNEWGRP01.isVisible"
					is-large>
					<q-control-wrapper
						v-if="controls.FR_001__PSEUDNEWGRP01.isVisible"
						class="row-line-group">
						<q-group-box-container
							v-if="controls.FR_001__PSEUDNEWGRP01.isVisible"
							id="FR_001__PSEUDNEWGRP01"
							v-bind="controls.FR_001__PSEUDNEWGRP01"
							:is-visible="controls.FR_001__PSEUDNEWGRP01.isVisible">
							<!-- Start FR_001__PSEUDNEWGRP01 -->
							<q-row-container v-if="controls.FR_001__T_001F_004___.isVisible">
								<q-control-wrapper
									v-if="controls.FR_001__T_001F_004___.isVisible"
									class="control-join-group control-dynamic-group">
									<base-input-structure
										v-if="controls.FR_001__T_001F_004___.isVisible"
										class="q-image"
										v-bind="controls.FR_001__T_001F_004___"
										v-on="controls.FR_001__T_001F_004___.handlers"
										:loading="controls.FR_001__T_001F_004___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-image
											v-if="controls.FR_001__T_001F_004___.isVisible"
											v-bind="controls.FR_001__T_001F_004___.props"
											v-on="controls.FR_001__T_001F_004___.handlers" />
									</base-input-structure>
								</q-control-wrapper>
							</q-row-container>
							<q-row-container
								v-if="controls.FR_001__T_001F_001___.isVisible"
								is-large>
								<q-control-wrapper
									v-if="controls.FR_001__T_001F_001___.isVisible"
									class="row-line-group">
									<base-input-structure
										v-if="controls.FR_001__T_001F_001___.isVisible"
										class="i-text"
										v-bind="controls.FR_001__T_001F_001___"
										v-on="controls.FR_001__T_001F_001___.handlers"
										:loading="controls.FR_001__T_001F_001___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-text-field
											v-bind="controls.FR_001__T_001F_001___.props"
											@blur="onBlur(controls.FR_001__T_001F_001___, model.ValName.value)"
											@change="model.ValName.fnUpdateValueOnChange" />
									</base-input-structure>
								</q-control-wrapper>
							</q-row-container>
							<q-row-container v-if="controls.FR_001__T_001F_002___.isVisible">
								<q-control-wrapper
									v-if="controls.FR_001__T_001F_002___.isVisible"
									class="control-join-group control-dynamic-group">
									<base-input-structure
										v-if="controls.FR_001__T_001F_002___.isVisible"
										class="i-text"
										v-bind="controls.FR_001__T_001F_002___"
										v-on="controls.FR_001__T_001F_002___.handlers"
										:loading="controls.FR_001__T_001F_002___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-mask
											v-if="controls.FR_001__T_001F_002___.isVisible"
											v-bind="controls.FR_001__T_001F_002___"
											:model-value="model.ValEmail.value"
											@change="model.ValEmail.fnUpdateValueOnChange" />
									</base-input-structure>
								</q-control-wrapper>
							</q-row-container>
							<q-row-container v-if="controls.FR_001__T_001F_003___.isVisible || controls.FR_001__T_001F_005___.isVisible">
								<q-control-wrapper
									v-if="controls.FR_001__T_001F_003___.isVisible"
									class="control-join-group">
									<base-input-structure
										v-if="controls.FR_001__T_001F_003___.isVisible"
										class="i-text"
										v-bind="controls.FR_001__T_001F_003___"
										v-on="controls.FR_001__T_001F_003___.handlers"
										:loading="controls.FR_001__T_001F_003___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-date-time-picker
											v-if="controls.FR_001__T_001F_003___.isVisible"
											v-bind="controls.FR_001__T_001F_003___.props"
											:model-value="model.ValDobirth.value"
											@reset-icon-click="model.ValDobirth.fnUpdateValue(model.ValDobirth.originalValue ?? new Date())"
											@update:model-value="model.ValDobirth.fnUpdateValue($event ?? '')" />
									</base-input-structure>
								</q-control-wrapper>
								<q-control-wrapper
									v-if="controls.FR_001__T_001F_005___.isVisible"
									class="control-join-group">
									<base-input-structure
										v-if="controls.FR_001__T_001F_005___.isVisible"
										class="i-text"
										v-bind="controls.FR_001__T_001F_005___"
										v-on="controls.FR_001__T_001F_005___.handlers"
										:loading="controls.FR_001__T_001F_005___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-numeric-input
											v-if="controls.FR_001__T_001F_005___.isVisible"
											v-bind="controls.FR_001__T_001F_005___.props"
											@update:model-value="model.ValTel.fnUpdateValue" />
									</base-input-structure>
								</q-control-wrapper>
							</q-row-container>
							<q-row-container v-if="controls.FR_001__AT_01F_001___.isVisible || controls.FR_001__AT_02F_001___.isVisible">
								<q-control-wrapper
									v-if="controls.FR_001__AT_01F_001___.isVisible"
									class="control-join-group">
									<base-input-structure
										v-if="controls.FR_001__AT_01F_001___.isVisible"
										class="i-text"
										v-bind="controls.FR_001__AT_01F_001___"
										v-on="controls.FR_001__AT_01F_001___.handlers"
										:loading="controls.FR_001__AT_01F_001___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-lookup
											v-if="controls.FR_001__AT_01F_001___.isVisible"
											v-bind="controls.FR_001__AT_01F_001___.props"
											v-on="controls.FR_001__AT_01F_001___.handlers" />
										<q-see-more-fr001-at01f001
											v-if="controls.FR_001__AT_01F_001___.seeMoreIsVisible"
											v-bind="controls.FR_001__AT_01F_001___.seeMoreParams"
											v-on="controls.FR_001__AT_01F_001___.handlers" />
									</base-input-structure>
								</q-control-wrapper>
								<q-control-wrapper
									v-if="controls.FR_001__AT_02F_001___.isVisible"
									class="control-join-group">
									<base-input-structure
										v-if="controls.FR_001__AT_02F_001___.isVisible"
										class="i-text"
										v-bind="controls.FR_001__AT_02F_001___"
										v-on="controls.FR_001__AT_02F_001___.handlers"
										:loading="controls.FR_001__AT_02F_001___.props.loading"
										:reporting-mode-on="reportingModeCAV"
										:suggestion-mode-on="suggestionModeOn">
										<q-lookup
											v-if="controls.FR_001__AT_02F_001___.isVisible"
											v-bind="controls.FR_001__AT_02F_001___.props"
											v-on="controls.FR_001__AT_02F_001___.handlers" />
										<q-see-more-fr001-at02f001
											v-if="controls.FR_001__AT_02F_001___.seeMoreIsVisible"
											v-bind="controls.FR_001__AT_02F_001___.seeMoreParams"
											v-on="controls.FR_001__AT_02F_001___.handlers" />
									</base-input-structure>
								</q-control-wrapper>
							</q-row-container>
							<!-- End FR_001__PSEUDNEWGRP01 -->
						</q-group-box-container>
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

	import FormViewModel from './QFormFr001ViewModel.js'

	const requiredTextResources = ['QFormFr001', 'hardcoded', 'messages']

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FORM_INCLUDEJS FR_001]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

	export default {
		name: 'QFormFr001',

		components: {
			QSeeMoreFr001At01f001: defineAsyncComponent(() => import('@/views/forms/FormFr001/dbedits/Fr001At01f001SeeMore.vue')),
			QSeeMoreFr001At02f001: defineAsyncComponent(() => import('@/views/forms/FormFr001/dbedits/Fr001At02f001SeeMore.vue')),
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
					name: 'FR_001',
					location: 'form-FR_001',
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
				componentOnLoadProc: asyncProcM.getProcListMonitor('QFormFr001', false),

				interfaceMetadata: {
					id: 'QFormFr001', // Used for resources
					requiredTextResources
				},

				formInfo: {
					type: 'normal',
					name: 'FR_001',
					route: 'form-FR_001',
					area: 'T_001',
					primaryKey: 'ValCodt_001',
					designation: computed(() => this.Resources.AGENT00994),
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
					FR_001__T_001F_008___: new fieldControlClass.NumberControl({
						modelField: 'ValPropsold',
						valueChangeEvent: 'fieldChange:t_001.propsold',
						id: 'FR_001__T_001F_008___',
						name: 'F_008',
						size: 'medium',
						label: computed(() => this.Resources.PROPERTIES_SOLD24318),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						isFormulaBlocked: true,
						maxIntegers: 3,
						maxDecimals: 0,
						controlLimits: [
						],
					}, this),
					FR_001__T_001F_009___: new fieldControlClass.CurrencyControl({
						modelField: 'ValProfit',
						valueChangeEvent: 'fieldChange:t_001.profit',
						id: 'FR_001__T_001F_009___',
						name: 'F_009',
						size: 'medium',
						label: computed(() => this.Resources.PROFITS_GENERATED31914),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						isFormulaBlocked: true,
						maxIntegers: 10,
						maxDecimals: 4,
						controlLimits: [
						],
					}, this),
					FR_001__PSEUDNEWGRP01: new fieldControlClass.GroupControl({
						id: 'FR_001__PSEUDNEWGRP01',
						name: 'NEWGRP01',
						size: 'block',
						label: computed(() => this.Resources.AGENT_INFOS64505),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						isCollapsible: false,
						anchored: false,
						directChildren: ['FR_001__T_001F_004___', 'FR_001__T_001F_001___', 'FR_001__T_001F_002___', 'FR_001__T_001F_003___', 'FR_001__T_001F_005___', 'FR_001__AT_01F_001___', 'FR_001__AT_02F_001___'],
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_001__T_001F_004___: new fieldControlClass.ImageControl({
						modelField: 'ValPhoto',
						valueChangeEvent: 'fieldChange:t_001.photo',
						id: 'FR_001__T_001F_004___',
						name: 'F_004',
						size: 'block',
						label: computed(() => this.Resources.PROFILE_PHOTO12166),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_001__PSEUDNEWGRP01',
						height: 50,
						width: 30,
						dataTitle: computed(() => genericFunctions.formatString(vm.Resources.IMAGEM_UTILIZADA_PAR17299, vm.Resources.PROFILE_PHOTO12166)),
						maxFileSize: 10485760, // In bytes.
						maxFileSizeLabel: '10 MB',
						controlLimits: [
						],
					}, this),
					FR_001__T_001F_001___: new fieldControlClass.StringControl({
						modelField: 'ValName',
						valueChangeEvent: 'fieldChange:t_001.name',
						id: 'FR_001__T_001F_001___',
						name: 'F_001',
						size: 'block',
						label: computed(() => this.Resources.NAME31974),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_001__PSEUDNEWGRP01',
						maxLength: 50,
						labelId: 'label_FR_001__T_001F_001___',
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_001__T_001F_002___: new fieldControlClass.MaskControl({
						modelField: 'ValEmail',
						valueChangeEvent: 'fieldChange:t_001.email',
						id: 'FR_001__T_001F_002___',
						name: 'F_002',
						size: 'block',
						label: computed(() => this.Resources.EMAIL25170),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_001__PSEUDNEWGRP01',
						maxLength: 50,
						labelId: 'label_FR_001__T_001F_002___',
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_001__T_001F_003___: new fieldControlClass.DateControl({
						modelField: 'ValDobirth',
						valueChangeEvent: 'fieldChange:t_001.dobirth',
						id: 'FR_001__T_001F_003___',
						name: 'F_003',
						size: 'medium',
						label: computed(() => this.Resources.DATE_OF_BIRTH36542),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_001__PSEUDNEWGRP01',
						dateTimeType: 'date',
						mustBeFilled: true,
						controlLimits: [
						],
					}, this),
					FR_001__T_001F_005___: new fieldControlClass.NumberControl({
						modelField: 'ValTel',
						valueChangeEvent: 'fieldChange:t_001.tel',
						id: 'FR_001__T_001F_005___',
						name: 'F_005',
						size: 'small',
						label: computed(() => this.Resources.TELEPHONE28697),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_001__PSEUDNEWGRP01',
						maxIntegers: 8,
						maxDecimals: 0,
						controlLimits: [
						],
					}, this),
					FR_001__AT_01F_001___: new fieldControlClass.LookupControl({
						modelField: 'TableAt_01F_001',
						valueChangeEvent: 'fieldChange:at_01.country',
						id: 'FR_001__AT_01F_001___',
						name: 'F_001',
						size: 'xxlarge',
						label: computed(() => this.Resources.COUNTRY_OF_ORIGIN50623),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_001__PSEUDNEWGRP01',
						externalCallbacks: {
							getModelField: vm.getModelField,
							getModelFieldValue: vm.getModelFieldValue,
							setModelFieldValue: vm.setModelFieldValue
						},
						externalProperties: {
							modelKeys: computed(() => vm.modelKeys)
						},
						lookupKeyModelField: {
							name: 'ValF_006',
							dependencyEvent: 'fieldChange:t_001.f_006'
						},
						dependentFields: () => ({
							set 'at_01.codt_003'(value) { vm.model.ValF_006.updateValue(value) },
							set 'at_01.country'(value) { vm.model.TableAt_01F_001.updateValue(value) },
						}),
						controlLimits: [
						],
					}, this),
					FR_001__AT_02F_001___: new fieldControlClass.LookupControl({
						modelField: 'TableAt_02F_001',
						valueChangeEvent: 'fieldChange:at_02.country',
						id: 'FR_001__AT_02F_001___',
						name: 'F_001',
						size: 'xxlarge',
						label: computed(() => this.Resources.COUNTRY_OF_RESIDENCE24197),
						placeholder: '',
						labelPosition: computed(() => this.labelAlignment.topleft),
						container: 'FR_001__PSEUDNEWGRP01',
						externalCallbacks: {
							getModelField: vm.getModelField,
							getModelFieldValue: vm.getModelFieldValue,
							setModelFieldValue: vm.setModelFieldValue
						},
						externalProperties: {
							modelKeys: computed(() => vm.modelKeys)
						},
						lookupKeyModelField: {
							name: 'ValF_007',
							dependencyEvent: 'fieldChange:t_001.f_007'
						},
						dependentFields: () => ({
							set 'at_02.codt_003'(value) { vm.model.ValF_007.updateValue(value) },
							set 'at_02.country'(value) { vm.model.TableAt_02F_001.updateValue(value) },
						}),
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
					'FR_001__PSEUDNEWGRP01',
				]),

				tableFields: readonly([
				]),

				timelineFields: readonly([
				]),

				/**
				 * The Data API for easy access to model variables.
				 */
				dataApi: {
					At_01: {
						get ValCountry() { return vm.model.TableAt_01F_001.value },
						set ValCountry(value) { vm.model.TableAt_01F_001.updateValue(value) },
					},
					At_02: {
						get ValCountry() { return vm.model.TableAt_02F_001.value },
						set ValCountry(value) { vm.model.TableAt_02F_001.updateValue(value) },
					},
					T_001: {
						get ValName() { return vm.model.ValName.value },
						set ValName(value) { vm.model.ValName.updateValue(value) },
						get ValEmail() { return vm.model.ValEmail.value },
						set ValEmail(value) { vm.model.ValEmail.updateValue(value) },
						get ValDobirth() { return vm.model.ValDobirth.value },
						set ValDobirth(value) { vm.model.ValDobirth.updateValue(value) },
						get ValPhoto() { return vm.model.ValPhoto.value },
						set ValPhoto(value) { vm.model.ValPhoto.updateValue(value) },
						get ValTel() { return vm.model.ValTel.value },
						set ValTel(value) { vm.model.ValTel.updateValue(value) },
						get ValF_006() { return vm.model.ValF_006.value },
						set ValF_006(value) { vm.model.ValF_006.updateValue(value) },
						get ValF_007() { return vm.model.ValF_007.value },
						set ValF_007(value) { vm.model.ValF_007.updateValue(value) },
						get ValPropsold() { return vm.model.ValPropsold.value },
						set ValPropsold(value) { vm.model.ValPropsold.updateValue(value) },
						get ValProfit() { return vm.model.ValProfit.value },
						set ValProfit(value) { vm.model.ValProfit.updateValue(value) },
					},
					keys: {
						/** The primary key of the T_001 table */
						get t_001() { return vm.model.ValCodt_001 },
						/** The foreign key to the AT_01 table */
						get at_01() { return vm.model.ValF_006 },
						/** The foreign key to the AT_02 table */
						get at_02() { return vm.model.ValF_007 },
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
// USE /[MANUAL RMS FORM_CODEJS FR_001]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		beforeUnmount()
		{
/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS COMPONENT_BEFORE_UNMOUNT FR_001]/
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
// USE /[MANUAL RMS BEFORE_LOAD_JS FR_001]/
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
// USE /[MANUAL RMS FORM_LOADED_JS FR_001]/
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
// USE /[MANUAL RMS BEFORE_APPLY_JS FR_001]/
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
// USE /[MANUAL RMS AFTER_APPLY_JS FR_001]/
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
// USE /[MANUAL RMS BEFORE_SAVE_JS FR_001]/
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
// USE /[MANUAL RMS AFTER_SAVE_JS FR_001]/
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
// USE /[MANUAL RMS BEFORE_DEL_JS FR_001]/
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
// USE /[MANUAL RMS AFTER_DEL_JS FR_001]/
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
// USE /[MANUAL RMS BEFORE_EXIT_JS FR_001]/
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
// USE /[MANUAL RMS AFTER_EXIT_JS FR_001]/
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
// USE /[MANUAL RMS DLGUPDT FR_001]/
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
// USE /[MANUAL RMS CTRLBLR FR_001]/
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
// USE /[MANUAL RMS CTRLUPD FR_001]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */

				this.afterControlUpdate(controlField, fieldValue)
			},

/* eslint-disable indent, vue/html-indent, vue/script-indent */
// USE /[MANUAL RMS FUNCTIONS_JS FR_001]/
// eslint-disable-next-line
/* eslint-enable indent, vue/html-indent, vue/script-indent */
		},

		watch: {
		}
	}
</script>
