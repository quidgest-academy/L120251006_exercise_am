/* eslint-disable @typescript-eslint/no-unused-vars */
import { computed, reactive, watch } from 'vue'
import _merge from 'lodash-es/merge'

import FormViewModelBase from '@/mixins/formViewModelBase.js'
import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
import modelFieldType from '@quidgest/clientapp/models/fields'

import hardcodedTexts from '@/hardcodedTexts.js'
import netAPI from '@quidgest/clientapp/network'
import qApi from '@/api/genio/quidgestFunctions.js'
import qFunctions from '@/api/genio/projectFunctions.js'
import qProjArrays from '@/api/genio/projectArrays.js'
/* eslint-enable @typescript-eslint/no-unused-vars */

/**
 * Represents a ViewModel class.
 * @extends FormViewModelBase
 */
export default class ViewModel extends FormViewModelBase
{
	/**
	 * Creates a new instance of the ViewModel.
	 * @param {object} vueContext - The Vue context
	 * @param {object} options - The options for the ViewModel
	 * @param {object} values - A ViewModel instance to copy values from
	 */
	// eslint-disable-next-line @typescript-eslint/no-unused-vars
	constructor(vueContext, options, values)
	{
		super(vueContext, options)
		// eslint-disable-next-line @typescript-eslint/no-unused-vars
		const vm = this.vueContext

		// The view model metadata
		_merge(this.modelInfo, {
			name: 'FR_005',
			area: 'T_006',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_Fr_005',
				updateFilesTickets: 'UpdateFilesTicketsFr_005',
				setFile: 'SetFileFr_005'
			}
		})

		/** The primary key. */
		this.ValCodt_006 = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodt_006',
			originId: 'ValCodt_006',
			area: 'T_006',
			field: 'CODT_006',
			description: '',
		}).cloneFrom(values?.ValCodt_006))
		this.stopWatchers.push(watch(() => this.ValCodt_006.value, (newValue, oldValue) => this.onUpdate('t_006.codt_006', this.ValCodt_006, newValue, oldValue)))

		/** The used foreign keys. */
		this.ValCodt_002 = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodt_002',
			originId: 'ValCodt_002',
			area: 'T_006',
			field: 'F_003',
			relatedArea: 'T_002',
			description: '',
		}).cloneFrom(values?.ValCodt_002))
		this.stopWatchers.push(watch(() => this.ValCodt_002.value, (newValue, oldValue) => this.onUpdate('t_006.codt_002', this.ValCodt_002, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValPhoto = reactive(new modelFieldType.Image({
			id: 'ValPhoto',
			originId: 'ValPhoto',
			area: 'T_006',
			field: 'F_001',
			description: computed(() => this.Resources.PHOTO51874),
		}).cloneFrom(values?.ValPhoto))
		this.stopWatchers.push(watch(() => this.ValPhoto.value, (newValue, oldValue) => this.onUpdate('t_006.photo', this.ValPhoto, newValue, oldValue)))

		this.ValDescription = reactive(new modelFieldType.String({
			id: 'ValDescription',
			originId: 'ValDescription',
			area: 'T_006',
			field: 'F_002',
			maxLength: 200,
			description: computed(() => this.Resources.DESCRIPTION07383),
		}).cloneFrom(values?.ValDescription))
		this.stopWatchers.push(watch(() => this.ValDescription.value, (newValue, oldValue) => this.onUpdate('t_006.description', this.ValDescription, newValue, oldValue)))

		this.TableT_002F_002 = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableT_002F_002',
			originId: 'ValTitle',
			area: 'T_002',
			field: 'F_002',
			maxLength: 50,
			description: computed(() => this.Resources.PROPERTY_TITLE56931),
		}).cloneFrom(values?.TableT_002F_002))
		this.stopWatchers.push(watch(() => this.TableT_002F_002.value, (newValue, oldValue) => this.onUpdate('t_002.title', this.TableT_002F_002, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFr005ViewModel instance.
	 * @returns {QFormFr005ViewModel} A new instance of QFormFr005ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodt_006'

	get QPrimaryKey() { return this.ValCodt_006.value }
	set QPrimaryKey(value) { this.ValCodt_006.updateValue(value) }
}
